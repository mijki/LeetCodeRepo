namespace LeetCodeRepo.Problems.Programming_skills_I;

public class _1678_GoalParserInterpretation {
    public static string Interpret(string command) {
        string res = "";
        for(int i=0; i<command.Length; i++){
            if(command[i]=='G') res += "G";
            else if(command[i]=='(' && command[i+1]==')'){
                res += "o";
                i++;
            }
            else if(command[i]=='(' && command[i+1]=='a'){
                res += "al";
                i+=3;
            }
        }
        return res;
    }
}