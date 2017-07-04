restart;
url := currentdir();
libname := libname, url;
with(TriSim);
f :=cos(x)*tan(x)/sin(x)^2-cot(x)*cos(x);
Simplify_Tri(f);
print_SOL(f);
