


class Frame {

    public List<int> runs = new(){};
    private int max = 2;
    public bool completed = false;


    public bool Add(int pins, bool lastFrame) {

        
        if (this.runs.Count <= this.max) {
            this.runs.Add(pins);
            
        }

        if (this.Pins() >= 10 && lastFrame) {
            
            
            this.max = 3;
           
        } else if (this.Pins() >= 10) {
            
            this.max = this.runs.Count;
           
        }

        return this.runs.Count >= this.max;
    }

    public Extra Status() {
    
        if (this.Pins() < 10 ) return Extra.NONE;
        else return (Extra)this.runs.Count;
    }
    
    public int Pins() {

        int total = 0;

        foreach (int pins in runs)
        {
            total += pins;
        }

      return total;
    }
    
}

public enum Extra {
    NONE,
    STRIKE,
    SPARE,
    
}