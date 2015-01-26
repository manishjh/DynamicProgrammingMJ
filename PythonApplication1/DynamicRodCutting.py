import time
p = [1, 5, 8, 9, 10, 17, 17, 20, 24, 30]
n=int(input())

start_time = time.time()
def cut_rod_dyn(p,n):
    r=[]
    for i in range(0,n+1):
        r.append(float('-inf'))
    return cut_rod(p,n,r)



def cut_rod(p, n, r):
    if r[n]>=0:
        return r[n]
    if n==0:
        return 0
    q = float('-inf')
    for i in range(n):
        q = max(q, p[i] + cut_rod(p, n - 1 - i,r))
    r[n]=q
    return q


print(cut_rod_dyn(p,n))
print((time.time()-start_time)*1000)
