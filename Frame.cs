


class Frame {

    private List<int?> runs = new(){};

    private int max = 2;

    public void Add(int pins) {

        if (runs.Count > this.max) runs.Add(pins);

    }

    public Extra Status() {

    return (Extra)this.runs.Count;
    }

}

public enum Extra {
    NONE,
    SPARE,
    STRIKE
}