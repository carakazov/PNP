package Nodes.Classes;
import Nodes.Interface.AbstractNode;

public class NegationNode implements AbstractNode
{
    private final AbstractNode child;

    public NegationNode(AbstractNode child)
    {
        this.child = child;
    }

    public Boolean calculate()
    {
        return !child.calculate();
    }

    public String toString()
    {
        return "child -> " + child;
    }
}
