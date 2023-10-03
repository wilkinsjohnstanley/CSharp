/*
Loop fusion is the technique of combining two loops
into one. For example, suppose that you want to call
two methods 100 times each. You can set a constant
named TIMES to 100 and use the following code:
*/
for(int x = 0; x < TIMES; ++x)
{
  method1();
  method2();
}
