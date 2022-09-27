namespace LeetCodeRepo.Problems.Programming_skills_I;

public class _496_NextGreaterElement {
    public static int[] NextGreaterElement(int[] nums1, int[] nums2) {
        int[] res = new int[nums1.Length];
        bool isBigger = false; 
        
        for(int i = 0; i < nums1.Length; i++){
            for(int j = 0; j < nums2.Length; j++){
                if(nums1[i] == nums2[j]){
                    for(int k = j; k < nums2.Length; k++){
                        if(nums2[k] > nums1[i]){
                            res[i] = nums2[k];
                            isBigger = true;
                            break;
                        }
                    }
                    if(!isBigger) res[i] = -1;
                    isBigger = false;
                }
            }
        }
        return res;
    }
}