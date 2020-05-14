package Nodes.Classes;
import Nodes.Interface.AbstractNode;
import java.util.List;

public class XORNode implements AbstractNode
{
    private final List<AbstractNode> childList;

    public XORNode(List<AbstractNode> childList)
    {
        this.childList = childList;
    }

    public Boolean calculate()
    {
        Boolean result = childList.get(0).calculate();
        for(int i = 1; i < childList.size(); i++)
        {
            result ^= childList.get(i).calculate();
        }
        return result;
    }

    public String toString()
    {
        String result = "";
        boolean first = true;
        for (AbstractNode node : childList)
        {
            if (!first)
            {
                result += " ^ ";
            }
            first = false;
            result += "(" + node + ")";
        }
        return result;
    }
}
