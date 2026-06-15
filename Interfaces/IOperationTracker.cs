public interface IOperationTracker
{
    int OrderCount {get;} //Reference this article: https://jeremybytes.blogspot.com/2019/11/c-8-interfaces-public-private-and.html
    public void Increment();
}