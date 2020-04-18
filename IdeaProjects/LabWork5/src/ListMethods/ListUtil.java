package ListMethods;
import ListObjects.ListPoint;

public class ListUtil
{
    public static void insert(ListPoint head, int x, int y)
    {
        ListPoint pointer = head;
        if(pointer.getNext() == null)
        {
            pointer.setNext(new ListPoint(x,y));
        }
        else
        {
            pointer = pointer.getNext();
            insert(pointer,x,y);
        }
    }

    public static void clearList(ListPoint head)
    {
        if(head.getNext() != null)
        {
            if(head.getX() < 0 || head.getY() < 0)
            {

            }
        }
    }
}
