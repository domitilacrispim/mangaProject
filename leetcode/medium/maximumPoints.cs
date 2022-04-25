public class Solution {
    public int MaxScore(int[] cardPoints, int k) {
        int[] maxSum = new int[cardPoints.Count()+k];
        int max=-1;
        for(int i=k-1; i>=-1; i-- ){
            if(max==-1){
                max=0;
                for(int j=i; j>=0; j--){
                    max=max+cardPoints[j];
                }
                maxSum[i+1]=max;
            }
            else{
                maxSum[i+1]= maxSum[i+2]-cardPoints[i+1]+
                    cardPoints[cardPoints.Count()-k+(i+1)];
                
               if(maxSum[i+1]>max){
                    max= maxSum[i+1];
                }
            }
        }
        return max;
    }
}
// 1423. Maximum Points You Can Obtain from Cards
