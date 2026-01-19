// Last updated: 1/19/2026, 12:36:02 PM
1class Solution {
2public:
3    int countPrimes(int n) {
4        int cnt = 0;
5        vector<bool> prime(n + 1, true);
6        prime[0] = prime[1] = false;
7        for (int i = 2; i < n; i++) {
8            if (prime[i]) {
9                cnt++;
10                for (int j = i * 2; j < n; j = j + i) {
11                    prime[j] = 0;
12                }
13            }
14        }
15        return cnt;
16    }
17};