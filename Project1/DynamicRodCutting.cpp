#include<iostream>
#include<stdio.h>
#include<conio.h>
#include<math.h>
#include<vector>
#include<time.h>
using namespace std;

int max(int a, int b)
{
	return a > b ? a : b;
}

int cut_rod(vector<int> &p, int n, vector<int> &r)
{
	if (r[n] >= 0)
	{
		return r[n];
	}
	if (n == 0)
	{
		return 0;
	}
	int q = INT_MIN;
	for (int i = 0; i < n; i++)
	{
		q = max(q, p[i] + cut_rod(p, n - 1 - i,r));
	}
	r[n] = q;
	return q;
}

int cut_rod_dyn(vector<int> p, int &n)
{
	vector<int> r = {};
	for (int i = 0; i < n + 1; i++)
	{
		r.push_back(INT_MIN);
	}
	return cut_rod(p, n, r);

}
int main()
{
	int n;
	const vector<int> p = { 1, 5, 8, 9, 10, 17, 17, 20, 24, 30 };
	cin >> n;
	clock_t tStart = clock();
	cout << endl<<cut_rod_dyn(p, n)<<endl;
	cout << (float)(clock() - tStart);

	_getch();
}