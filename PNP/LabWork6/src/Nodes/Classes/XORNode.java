package Nodes.Classes;
import Nodes.Interface.AbstractNode;

public class XORNode implements AbstractNode
{
    private final AbstractNode left;
    private final AbstractNode right;

    public XORNode(AbstractNode left, AbstractNode right)
    {
        this.left = left;
        this.right = right;
    }

    public Boolean calculate()
    {
        return left.calculate() ^ right.calculate();
    }

    public String toString()
    {

        return "left -> " + left + "right -> " + right + " ";
    }
}
