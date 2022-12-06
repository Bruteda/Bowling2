class Game {


    List<Frame> frames = new();
    int currentIndex = 0;
    int maxFrames = 10;

    public Game()
    {
        this.frames.Add(new Frame());
    }


    public void Roll(int pins) {

        bool lastFrame = this.currentIndex == this.maxFrames - 1;
        
        if(this.currentIndex < this.maxFrames ) {

            bool completed = this.frames[this.currentIndex].Add(pins, lastFrame);

            if (completed && (this.currentIndex < this.maxFrames)) {
                this.frames.Add(new Frame());
                this.currentIndex ++;
            }
        }

    }

    public int Score() {
        int total = 0;
        int i = 0;
        foreach (Frame frame in this.frames)
        {
            
            total += frame.Pins();
            
            Extra currentExtra = frame.Status();

            switch (currentExtra)
            {
                case Extra.STRIKE:
                    total += GetBonusPoints(i, 2);
                    
                    break;
                 case Extra.SPARE:
                    total += GetBonusPoints(i, 1);
 
                    break;
 
 
                default:
                    break;
            }
            i++;
        }

        return total;
    }




    public int GetBonusPoints(int index, int bonusRolls)
    {
        int i = index;
        int found = 0;
        int total = 0;

        while (found < bonusRolls)
        {
            try
            {
                Frame current = this.frames[i + 1];

                for (int l = 0; l < current.runs.Count; l++)
                {
                    total += current.runs[l];
                    found ++;
                
                }
                i++;
            }
            catch (System.Exception)
            {
                found = bonusRolls;
            }
        }

        return total;
    }
}