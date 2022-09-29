using LeetCodeRepo.Problems;
using LeetCodeRepo.Problems.Programming_skills_I;

/*Task1: Two Sum
    int[] nums = { 3, 2, 4 };
    int target = 6;
    TwoSum.TwoSumMethod(nums, target);
*/

/*Task2: Number of Digit One
    int n = 824883294;
    Console.WriteLine(_233_NumberOfDigitOne.CountDigitOne(n));
*/

/*Task3: Reverse Words in String III
string s = "Let's take LeetCode contest";
Console.WriteLine(_557_ReverseWordsInString.ReverseWords(s));
*/

/*Programming Skills I.
 * 
 * Day1:
 * Task4: Count Odd Numbers in an Interval Range
           Console.WriteLine(_1523_CountOddNumbersInAnInvertalRange.CountOdds(3, 7));
 * Task5: 1491. Average Salary Excluding the Minimum and Maximum Salary
           int[] salary = { 4000, 3000, 1000, 2000 };
           Console.WriteLine(_1491_AverageSalaryExcludingTheMinMaxSalary.Average(salary));
*/

/*
 * Day2:
 * 191: Number of 1 Bits
    uint n = 11111111111111111111111111111101;
    Console.WriteLine(_191_NumberOfOneBits.HammingWeight(n));
    1281: Subtract the Product and Sum of Digits of an Integer
    Given an integer number n, return the difference between the product of its digits and the sum of its digits.
    Console.WriteLine(_1281_SubtractTheProducts.SubtractProductAndSum(234));*/

/*Day3:
 Task 1:
    976. Largest perimeter triangle
    Given an integer array nums, return the largest perimeter of a triangle with a non-zero area, formed from three of these lengths. 
    If it is impossible to form any triangle of a non-zero area, return 0.
        int[] nums = { 3, 6, 2, 3 };
        Console.WriteLine(_976_LargestPerimeterTriangle.LargestPerimeter(nums));
 Task2:
    1779. Find Nearest Point That Has the Same X or Y Coordinate

        int x = 3;
        int y = 4;
        int[][] points = new int[][] { new int[] { 3,4} };
        Console.WriteLine(_1779_NearesPointThatHasTheSameCoordinates.NearestValidPoint(x, y, points));*/

/*Day4:
 1822. Sign of the Product Of An Array
        int[] nums = {50,25,95,36,30,74,56,90,13,51,48,94,47,9,16,62,20,33,7,2,34,84,48,22,67,34,48,28,56,65,13,35,90,2,97,84,56,48,18,72,38,94,42,37,34,46,-43,-38,-62,-88,-48,-55,-65,-17,-80};
        Console.WriteLine(_1822_SignOfTheProductOfAnArray.ArraySign(nums));*/
/*1502. Can Make Arithmetic Progression From Sequence
        int[] arr = { 3, 5, 1 };
        Console.WriteLine(_1502_CanMakeArithmeticProgFromSeq.CanMakeArithmeticProgression(arr));*/
/*202. Happy Number
        Console.WriteLine(_202_HappyNumber.IsHappy(2));*/
/*1790. Check if One String Swap Can Make Strings Equal
        string s1 = "bankb";
        string s2 = "kannb";
        Console.WriteLine(Convert.ToString(_1790_CheckIfOneStringSwapMakeStringsEqual.AreAlmostEqual(s1, s2)));*/

/*Day5:
 589. N-ary Tree Preorder Traversal
 496. Next Greater Element I
        int[] nums1 = { 4, 1, 2 };
        int[] nums2 = { 1, 3, 4, 2 };
        _496_NextGreaterElement.NextGreaterElement(nums1, nums2);*/
/*1232. Check If It Is a Straight Line
        int[][] coordinates =
        {
            new int[] { 1, 2 },
            new int[] { 2, 3 },
            new int[] { 3, 4 },
            new int[] { 4, 5 },
            new int[] { 5, 6 },
            new int[] { 6, 7 }
        };
        Console.WriteLine(_1232_CheckIfItIsAStraightLine.CheckStraightLine(coordinates));*/

/*Day8:
    1768. Merge Strings Alternatively
        string word1 = "abcd";
        string word2 = "pq";
        Console.WriteLine(_1768_MergeStringsAlternately.mergeAlternately(word1, word2));
    1678. Goal Parser Interpretation
        string command = "G()(al)";
        Console.WriteLine(_1678_GoalParserInterpretation.Interpret(command));
    389. Find the Difference*/
string s =
    "ymbgaraibkfmvocpizdydugvalagaivdbfsfbepeyccqfepzvtpyxtbadkhmwmoswrcxnargtlswqemafandgkmydtimuzvjwxvlfwlhvkrgcsithaqlcvrihrwqkpjdhgfgreqoxzfvhjzojhghfwbvpfzectwwhexthbsndovxejsntmjihchaotbgcysfdaojkjldprwyrnischrgmtvjcorypvopfmegizfkvudubnejzfqffvgdoxohuinkyygbdzmshvyqyhsozwvlhevfepdvafgkqpkmcsikfyxczcovrmwqxxbnhfzcjjcpgzjjfateajnnvlbwhyppdleahgaypxidkpwmfqwqyofwdqgxhjaxvyrzupfwesmxbjszolgwqvfiozofncbohduqgiswuiyddmwlwubetyaummenkdfptjczxemryuotrrymrfdxtrebpbjtpnuhsbnovhectpjhfhahbqrfbyxggobsweefcwxpqsspyssrmdhuelkkvyjxswjwofngpwfxvknkjviiavorwyfzlnktmfwxkvwkrwdcxjfzikdyswsuxegmhtnxjraqrdchaauazfhtklxsksbhwgjphgbasfnlwqwukprgvihntsyymdrfovaszjywuqygpvjtvlsvvqbvzsmgweiayhlubnbsitvfxawhfmfiatxvqrcwjshvovxknnxnyyfexqycrlyksderlqarqhkxyaqwlwoqcribumrqjtelhwdvaiysgjlvksrfvjlcaiwrirtkkxbwgicyhvakxgdjwnwmubkiazdjkfmotglclqndqjxethoutvjchjbkoasnnfbgrnycucfpeovruguzumgmgddqwjgdvaujhyqsqtoexmnfuluaqbxoofvotvfoiexbnprrxptchmlctzgqtkivsilwgwgvpidpvasurraqfkcmxhdapjrlrnkbklwkrvoaziznlpor";
string t =
    "qhxepbshlrhoecdaodgpousbzfcqjxulatciapuftffahhlmxbufgjuxstfjvljybfxnenlacmjqoymvamphpxnolwijwcecgwbcjhgdybfffwoygikvoecdggplfohemfypxfsvdrseyhmvkoovxhdvoavsqqbrsqrkqhbtmgwaurgisloqjixfwfvwtszcxwktkwesaxsmhsvlitegrlzkvfqoiiwxbzskzoewbkxtphapavbyvhzvgrrfriddnsrftfowhdanvhjvurhljmpxvpddxmzfgwwpkjrfgqptrmumoemhfpojnxzwlrxkcafvbhlwrapubhveattfifsmiounhqusvhywnxhwrgamgnesxmzliyzisqrwvkiyderyotxhwspqrrkeczjysfujvovsfcfouykcqyjoobfdgnlswfzjmyucaxuaslzwfnetekymrwbvponiaojdqnbmboldvvitamntwnyaeppjaohwkrisrlrgwcjqqgxeqerjrbapfzurcwxhcwzugcgnirkkrxdthtbmdqgvqxilllrsbwjhwqszrjtzyetwubdrlyakzxcveufvhqugyawvkivwonvmrgnchkzdysngqdibhkyboyftxcvvjoggecjsajbuqkjjxfvynrjsnvtfvgpgveycxidhhfauvjovmnbqgoxsafknluyimkczykwdgvqwlvvgdmufxdypwnajkncoynqticfetcdafvtqszuwfmrdggifokwmkgzuxnhncmnsstffqpqbplypapctctfhqpihavligbrutxmmygiyaklqtakdidvnvrjfteazeqmbgklrgrorudayokxptswwkcircwuhcavhdparjfkjypkyxhbgwxbkvpvrtzjaetahmxevmkhdfyidhrdeejapfbafwmdqjqszwnwzgclitdhlnkaiyldwkwwzvhyorgbysyjbxsspnjdewjxbhpsvj";
        Console.WriteLine(Convert.ToString(_389_FindTheDifference.FindTheDifference(s, t)));
    

    


    

    




