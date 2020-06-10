import ListMethods.ListUtil;
import ListObjects.ListPoint;


public class LabWork5
{
    public static void main(String[] args)
    {
        ListPoint point = new ListPoint(1,1);
        ListPoint point1 = new ListPoint(2,2);
        point.setNext(point1);
        ListUtil.insert(point, 5, 3);
        System.out.println(point1.getNext().getX());
        System.out.println(point1.getNext().getY());
    }
}
