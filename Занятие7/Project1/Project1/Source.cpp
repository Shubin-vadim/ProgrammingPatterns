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


long long cpow(long long a, long long b) {
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


bool cfind(vector<NotLike>& v, NotLike w) {
	int n = v.size();
	for (int i = 0; i < n; i++) {
		if (v[i].a == w.a && v[i].b == w.b && v[i].c == w.c) {
			return true;
		}
	}
	return false;
}

int main() {
	long long n, m, k;
	long long a, b, c;
	vector<NotLike>NotSentenc;
	cin >> n >> m >> k;

	for (int i = 0; i < k; i++) {
		cin >> a >> b >> c;
		NotLike el = { a,b,c };
		if (!cfind(NotSentenc, el)) {
			NotSentenc.push_back({ a,b,c });
		}
	}


	long long cnt_sentenc = cpow(m, n);
	int rn = NotSentenc.size();
	cout << cnt_sentenc - rn;

	return 0;
}