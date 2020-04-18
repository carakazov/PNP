package Nodes.Classes;
import Nodes.Interface.AbstractNode;

public class SimpleNode implements  AbstractNode
{
    private final Boolean value;
    public SimpleNode(Boolean value)
    {
        this.value = value;
    }

    public Boolean calculate()
    {
        return value;
    }

    public String toString()
    {
        return String.valueOf(value) + " ";
    }
}
