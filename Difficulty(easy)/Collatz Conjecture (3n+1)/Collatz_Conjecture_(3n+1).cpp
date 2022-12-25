// DONE!
unsigned int hotpo(unsigned int n){
   
    int counter=0;  
    if(n == 1 || n == 0) return 0;
    while(n>1)
    {
        if(n%2 == 0) n = n/2;
        else n = 3*n+1;
        counter++;
    }    
    return counter;    
}
