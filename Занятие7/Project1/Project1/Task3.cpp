#include <iostream>
#include <vector>
#include <cmath>
#include <map>
#include <queue>
#include <set>

using namespace std;

long long mod = 998244353;

struct NotLike {
	long long a, b, c;
};

long long fact(long long n) {
	if (n == 0) {
		return 1;
	}

	long long rez = 1;
	for (int i = 2; i <= n; i++) {
		rez *= (i % mod);
	}

	return rez;
}


long long pow(long long a, long long b) {
	if (b == 0) {
		return 1;
	}

	if (b == 1) {
		return a;
	}

	long long rez = 1;
	for (int i = 1; i <= b; i++) {
		rez = (rez * a) % mod;
	}

	return rez;

}

int main() {
	long long n, m, k;
	long long a, b, c;
	set<NotLike>NotSentenc;
	cin >> n >> m >> k;

	for (int i = 0; i < k; i++) {
		cin >> a >> b >> c;
		NotSentenc.insert({ a,b,c });
	}


	long long cnt_sentenc = pow(m, n);
	cout << cnt_sentenc - NotSentenc.size();

	return 0;
}