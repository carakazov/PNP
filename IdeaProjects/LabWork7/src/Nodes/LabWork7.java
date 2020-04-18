package Nodes;

import Nodes.Classes.NegationNode;
import Nodes.Classes.SimpleNode;
import Nodes.Classes.XORNode;
import Nodes.Interface.AbstractNode;
import java.util.Arrays;
import java.util.List;

public class LabWork7 extends Application
{
    public static AbstractNode generateFirst()
    {
        List<AbstractNode> list = Arrays.asList(new SimpleNode(true), new NegationNode(new SimpleNode(false)), new NegationNode(new SimpleNode(true)));
        return new XORNode(list);
    }

    public static AbstractNode generateSecond()
    {
        List<AbstractNode> list = Arrays.asList(new NegationNode(new SimpleNode(true)), new NegationNode(new SimpleNode(false)));
        return new NegationNode(new XORNode(list));
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
