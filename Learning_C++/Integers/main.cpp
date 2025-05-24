#include <iostream>

int main() {
    /*
    //Braced initializers
    //Variable may  contain random garbage value. WARNING
    int elephant_count;
    
    int lion_count{}; //initializes to 0
    
    int dog_count{10};//initializes to 10
    
    int cat_count{15};//initializes to 15
    
    //Can use expression as initializer
    int domesticated_animals { dog_count + cat_count };
    
    //doesnt_exist isnt defined
    // int new_number{doesnt_exist}; 
    
    //int narrowing_conversion {2.9}; //error: narrowing conversion of ‘2.8999999999999999e+0’ from ‘double’ to ‘int’ [-Wnarrowing]
    
    std::cout << "elephant_count : " << elephant_count << std::endl; 
    std::cout << "lion_count : " << lion_count << std::endl; 
    std::cout << "dog_count : " << dog_count << std::endl; 
    std::cout << "cat_count : " << cat_count << std::endl; 
    std::cout << "domesticated_animals count : " << domesticated_animals << std::endl; 
    */
    
    /*
    //Functional Initialization
    int apple_count(5);
    int orange_count(10);
    int fruit_count(apple_count + orange_count);
    //int bad_initialization(doesnt_exist3 + doesnt_exist4);
    
    //information lost. less safe than braced initializers
    int narrowing_conversion_functional(2.9);
    
    std::cout << "apple_count : " << apple_count << std::endl; //5
    std::cout << "orange_count : " << orange_count << std::endl; //10
    std::cout << "fruit_count : " << fruit_count << std::endl; //15
    std::cout << "narrowing conversion : " << narrowing_conversion_functional << std::endl; //2 (loses the 2.9, since integers stores 4 bytes)
    */
    
    //Assignment notation
    int bike_count = 2;
    int truck_count = 7;
    int vehicle_count = bike_count + truck_count;
    int narrowing_conversion_assignment = 2.9;

    std::cout << "bike_count : " << bike_count << std::endl;
    std::cout << "truck_count : " << truck_count << std::endl;
    std::cout << "vehicle_count : " << vehicle_count << std::endl;
    std::cout << "narrowing_conversion_assignment : " << narrowing_conversion_assignment << std::endl;

    //Check the size with sizeof
    std::cout << "sizeof int : "<< sizeof(int) <<std::endl; //4
    std::cout << "sizeof truck_count : "<< sizeof(truck_count) <<std::endl;//4

    return 0;
}