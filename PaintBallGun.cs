using System;

namespace PaintBallGun
{
    class PaintBallGun {        
        private int balls = 0;

        public int BallsLoaded { get; private set; }
        public int MagazineSize { get; private set; } = 16;
        public bool isEmpty() { return BallsLoaded == 0; }

        public PaintBallGun(int balls, int magazineSize, bool loaded) {
            this.balls = balls;
            MagazineSize = magazineSize;
            if (!loaded) { 
                Reload();
            }
        }

    public int Balls
        {
            get { return balls; } 

            set {
                if (value > 0)
                    balls = value;
                Reload();
            }
        }
        public void Reload() {
            if (balls > MagazineSize)            
                balls = MagazineSize;            
            else
                BallsLoaded = balls;            
        }
        public bool Shoot() { 
            if(BallsLoaded == 0) 
                return false;
            --BallsLoaded;
            --balls;
            return true;
        }
    }
}
