#include <LiquidCrystal.h>
LiquidCrystal LcDisplay = LiquidCrystal(12, 11, 5, 4, 3, 2); //RS, E, D4, D5, D6, D7
void setup() {
  Serial.begin(9600);
    LcDisplay.clear();
}

void loop() {
  if(Serial.available()>0){
    String str = Serial.readString();
    Serial.println(str);
    LcDisplay.setCursor(0,0);
    LcDisplay.print(str);
    if(str == "clear"){
      LcDisplay.clear();
    }
}
  }




