package ListObjects;

public class ListPoint
{
    private final int x;
    private final int y;
    private ListPoint next;

    public ListPoint(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public int getX()
    {
        return x;
    }

    public int getY()
    {
        return y;
    }

    public ListPoint getNext()
    {
        return next;
    }

    public void setNext(ListPoint next)
    {
        this.next = next;
    }
}
