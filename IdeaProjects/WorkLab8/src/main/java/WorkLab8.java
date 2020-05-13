import java.util.Scanner;
import Lab8Class.StringChecker;

public class WorkLab8 {
    public static void main(String[] args){
        Scanner input = new Scanner(System.in);
        System.out.print("Input outer string: ");
        String outerString = input.nextLine();
        System.out.print("Input inner string: ");
        String innerString = input.nextLine();

        StringChecker stringChecker = new StringChecker();
        int index = stringChecker.checkString(outerString, innerString);

        if (index == -1){
            System.out.println("Inner string doesn't exist inside of outer one");
        }
        else
        {
            System.out.format("Inner string starts in outer one from %d index", index);
        }
    }
}
