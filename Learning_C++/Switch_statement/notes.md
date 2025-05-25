# Switch Statement
Alternative to if else clauses
Testing for several different conditions
```cpp
int tool { Pen };

switch(tool) {
    case Pen: {
        std::cout << "Active tool is Pen" <<std::endl;
    }
    break;
    case Marker: {
        std::cout << "Active tool is Marker" <<std::endl;
    }
    break;
    
    default: {
        std::cout << "Can't match any tool" << std::endl;
    }
}

```
Break; -> The break statement after each case is very important. It stops processing the switch block when a successful case has been found. If the break statement is not there, all the cases following the current case will be executed.

Condition -> Integral types and enums : int,long,unsigned short, etc.