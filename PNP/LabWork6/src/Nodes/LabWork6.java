package Nodes;

import Nodes.Classes.NegationNode;
import Nodes.Classes.SimpleNode;
import Nodes.Classes.XORNode;
import Nodes.Interface.AbstractNode;

public class LabWork6
{
    public static AbstractNode generateFirst()
    {
        return new XORNode(new XORNode(new SimpleNode(true), new NegationNode(new SimpleNode(false))), new NegationNode(new SimpleNode(true)));
    }
    public static AbstractNode generateSecond()
    {
        return new NegationNode(new XORNode(new NegationNode(new SimpleNode(true)), new NegationNode(new SimpleNode(false))));
    }
    public static void main(String[] args)
    {
        AbstractNode first = generateFirst();
        AbstractNode second = generateSecond();
        System.out.println(first.toString());
        System.out.println(first.calculate());
        System.out.println(second.toString());
        System.out.println(second.calculate());
    }
}
