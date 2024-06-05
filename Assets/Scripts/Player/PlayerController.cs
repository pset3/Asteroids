using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Asteroid
{
    public class PlayerController : MovableObjectController, InputActions.IGameplayActions, IDisposable
    {
        public new PlayerModel Model { get; private set; }

        const float AngularSpeed = 180;
        const float MaxSpeed = 8f;
        const float ForwardAcceleration = 4f;
        const float InertionAcceleration = 0.75f;
        const float InertionSpeedMultipler = 0.05f;
        const float FireShellCooldownTime = 0.25f;
        const float FireLaserCooldownTime = 0.25f;
        const float ReloadLaserTime = 5f;
        const int LaserMaxCount = 3;
        const float SpawnShellOffset = 0.5f;

        private InputActions controls;
        private bool isRotateRight;
        private bool isRotateLeft;
        private bool isMoveForward;
        private bool isFireShell;
        private Timer fireShellCooldown;
        private bool isFireLaser;
        private Game game;

        private Timer fireLaserCooldown;
        private Timer reloadLaserTimer;

        public PlayerController(PlayerModel model, PlayerView view, Game game) : base(model, view, game)
        {
            Model = model;
            this.game = game;
            Model.Rotation = 90;
            Model.LaserCount = LaserMaxCount;
            defaultMove = false;

            if (controls == null)
            {
                controls = new InputActions();
                controls.gameplay.SetCallbacks(this);
            }

            controls.gameplay.Enable();
            fireShellCooldown = new Timer(FireShellCooldownTime, game, null, true, true);
            fireLaserCooldown = new Timer(FireLaserCooldownTime, game, null, true, true);
            reloadLaserTimer = new Timer(ReloadLaserTime, game, ReloadLaser, false, false);
        }

        protected override void Update()
        {
            base.Update();

            if (isRotateRight)
                Model.Rotation -= AngularSpeed * Time.deltaTime;

            if (isRotateLeft)
                Model.Rotation += AngularSpeed * Time.deltaTime;

            Model.Speed += -(Model.Speed * (InertionAcceleration + Mathf.Pow(Model.Speed * InertionSpeedMultipler, 2f))) * Time.deltaTime;
            Model.SpeedX += -(Model.SpeedX * (InertionAcceleration + Mathf.Pow(Model.SpeedX * InertionSpeedMultipler, 2f))) * Time.deltaTime;
            Model.SpeedY += -(Model.SpeedY * (InertionAcceleration + Mathf.Pow(Model.SpeedY * InertionSpeedMultipler, 2f))) * Time.deltaTime;

            if (isMoveForward)
            {
                Model.Speed += ForwardAcceleration * Time.deltaTime;
                Model.SpeedX += ForwardAcceleration * Time.deltaTime * Mathf.Cos(Model.Rotation * Mathf.Deg2Rad);
                Model.SpeedY += ForwardAcceleration * Time.deltaTime * Mathf.Sin(Model.Rotation * Mathf.Deg2Rad);

                if (Model.Speed > MaxSpeed)
                {
                    float speedMult = Model.Speed / MaxSpeed;
                    Model.Speed = MaxSpeed;
                    Model.SpeedX /= speedMult;
                    Model.SpeedY /= speedMult;
                }
            }

            if (isFireShell && fireShellCooldown.IsReady)
            {
                FireShell();
                fireShellCooldown.StartTimer();
            }

            if (isFireLaser && fireLaserCooldown.IsReady && Model.LaserCount > 0)
            {
                FireLaser();
                Model.LaserCount--;
                fireLaserCooldown.StartTimer();
                reloadLaserTimer.StartTimer();
            }

            Model.ReloadLaserTime = reloadLaserTimer.Time;
        }

        private void FireShell()
        {
            Vector2 direct = new Vector2(Mathf.Cos(Model.Rotation * Mathf.Deg2Rad), Mathf.Sin(Model.Rotation * Mathf.Deg2Rad));
            Vector2 position = Model.Position + direct * SpawnShellOffset;
            ShellFactory.CreateShell(position, Model.Rotation, game);
        }

        private void FireLaser()
        {
            LaserFactory.CreateLaser(Model.Position, Model.Rotation, game);
        }

        private void ReloadLaser()
        {
            Model.LaserCount++;

            if (Model.LaserCount < LaserMaxCount)
            {
                reloadLaserTimer.StartTimer();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (!isDisposed)
            {
                if (disposing)
                {
                    base.Dispose(disposing);
                    controls.gameplay.Disable();
                }
            }
        }

        public void TakeScore(int score)
        {
            Model.Score += score;
        }

        public void Damage()
        {
            game.GameOver();
        }

        public void OnMoveLeft(InputAction.CallbackContext context)
        {
            if (context.phase == InputActionPhase.Started)
                isRotateLeft = true;
            if (context.phase == InputActionPhase.Canceled)
                isRotateLeft = false;
        }

        public void OnMoveRight(InputAction.CallbackContext context)
        {
            if (context.phase == InputActionPhase.Started)
                isRotateRight = true;
            if (context.phase == InputActionPhase.Canceled)
                isRotateRight = false;
        }

        public void OnMoveForward(InputAction.CallbackContext context)
        {
            if (context.phase == InputActionPhase.Started)
                isMoveForward = true;
            if (context.phase == InputActionPhase.Canceled)
                isMoveForward = false;
        }

        public void OnFire1(InputAction.CallbackContext context)
        {
            if (context.phase == InputActionPhase.Started)
                isFireShell = true;
            if (context.phase == InputActionPhase.Canceled)
                isFireShell = false;
        }

        public void OnFire2(InputAction.CallbackContext context)
        {
            if (context.phase == InputActionPhase.Started)
                isFireLaser = true;
            if (context.phase == InputActionPhase.Canceled)
                isFireLaser = false;
        }
    }
}