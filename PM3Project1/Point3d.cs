namespace PM3Project1;

public struct Point3d
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    public override string ToString()
    {
        return $"({X}, {Y}, {Z})";
    }

    public void InverseX()
    {
        X = -X;
    }
}