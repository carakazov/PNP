import Lab8Class.StringChecker;

public class WorkLab8 {
    public static void main(String[] args){
        StringChecker stringChecker = new StringChecker();
        String outerString = stringChecker.generateOuterString();
        String innerString = stringChecker.generateInnerString();
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
