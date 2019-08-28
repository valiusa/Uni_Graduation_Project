#include <BluetoothSerial.h>
#include <Servo.h>

#define MAX_ADC_READING 4095
#define ADC_REF_VOLTAGE 3.3
#define REF_RESITANCE 10
#define LUX_CALC_SCALAR 12518931
#define LUX_CALC_EXPONENT -2.15


void ChangeBlindsPosWithVoiceOrFromSensor(String _command);
void ChangeFanStateWithVoice(String _command);
void ChangeLightStateWithVoice(String _command);

void ChangeBlindsPosByHand(String _command);
void ChangeFanStateByHandOrFromSensor(String _command);
void ChangeLightStateByHandOrFromSensor(String _command);

Servo myServo;
int pos = 0; // Servo position

String command; // Stores the commands that are coming from the PC app trought voice
String sensorValuesToSend;

// ------------------------ Pin Setups ------------------------
// Light level sensor
int lsValue = 0;
int lsPin = A7;
float resistorVoltage = 0.0;
float ldrVoltage = 0.0;
float ldrResistance = 0.0;
float lux = 0.0;

// Humidity sensor
//int hsValue = 0;
//int hsPin = A6;

// Gas detection sensor
//int gsValue = 0;
//int gsPin = A5;

// Relays
//int r1 = 22;
//int r2 = 22;
int r3 = 12;
//int r4 = 8;
int bLed = 2;

// ------------------------ Tasks ------------------------
// Task 1 - voice commands
int period1 = 1000;
unsigned long time_now1 = 0;

// Task 2 - send light level sensor data
int period2 = 1000;
unsigned long time_now2 = 0;

BluetoothSerial SerialBT;

void setup() {
  Serial.begin(9600);  
  SerialBT.begin("ESP32test"); // Bluetooth name

  myServo.attach(13);    // Servo motor
  pinMode(lsPin, INPUT); // Light level sensor
  //pinMode(hsPin, INPUT); // Humidity sensor
  //pinMode(gsPin, INPUT); // Gas detection sensor

  //pinMode(r1, OUTPUT); // Relay 1
  //digitalWrite(r1, HIGH);
  //pinMode(r2, OUTPUT); // Relay 2  
  pinMode(r3, OUTPUT); // Relay 3
  digitalWrite(r3, HIGH);
  //pinMode(r4, OUTPUT); // Relay 4
  pinMode(bLed, OUTPUT);
  digitalWrite(bLed, LOW);
}

void loop() {
  // Task 1 commands -----------------------------------
  if(millis() > time_now1 + period1) {
    time_now1 = millis();
    
    while(SerialBT.available() > 0) {
      command = SerialBT.readString();
      Serial.println(command);

      ChangeBlindsPosWithVoiceOrFromSensor(command);
      ChangeBlindsPosByHand(command);

      ChangeFanStateWithVoice(command);
      ChangeFanStateByHandOrFromSensor(command);

      ChangeLightStateWithVoice(command);
      ChangeLightStateByHandOrFromSensor(command);
    }
  }

  // Task 2 Light sensor -----------------------------------
  if(millis() > time_now2 + period2) {
    time_now2 = millis();

    lsValue = analogRead(lsPin);

    resistorVoltage = (float)lsValue / (MAX_ADC_READING * ADC_REF_VOLTAGE);
    ldrVoltage = ADC_REF_VOLTAGE - resistorVoltage;
    ldrResistance = (ldrVoltage / resistorVoltage) * REF_RESITANCE;
    lux = LUX_CALC_SCALAR * pow(ldrResistance, LUX_CALC_EXPONENT);

    sensorValuesToSend += String(lux);
    sensorValuesToSend += "/";
    sensorValuesToSend += String(0);
    sensorValuesToSend += "/";
    sensorValuesToSend += String(0);

    Serial.println(sensorValuesToSend);
    SerialBT.print(sensorValuesToSend);

    sensorValuesToSend = "";
  }
}

// Blinds ---------------------------------------------
void ChangeBlindsPosWithVoiceOrFromSensor(String _command) {
  if(_command.indexOf("raiseblinds") != -1) {
    for(; pos < 180; pos++) {
      myServo.write(pos);
      delay(15);
    }
  }      
  else if(_command.indexOf("lowerblinds") != -1) {
    for(; pos >= 0; pos--) {
       myServo.write(pos);
       delay(15);
    }
  }
}

void ChangeBlindsPosByHand(String _command) {
  if(_command.indexOf("move0deg") != -1) {
    if(pos != 0) {
      for(; pos >= 0; pos--) {
        myServo.write(pos);
        delay(15);
      }
    }
  }
  else if(_command.indexOf("move60deg") != -1) {
    if(pos != 60) {
      if(pos < 60) {
        for(; pos < 60; pos++){
          myServo.write(pos);
          delay(15);
        }
      }
      else {
        for(; pos >= 60; pos--) {
           myServo.write(pos);
           delay(15);
        }
      }
    }
  }
  else if(_command.indexOf("move120deg") != -1) {
    if(pos != 120) {
      if(pos < 120) {
        for(; pos < 120; pos++){
          myServo.write(pos);
          delay(15);
        }
      }
      else {
        for(; pos >= 120; pos--) {
          myServo.write(pos);
          delay(15);
        }
      }
    }
  }
  else if(_command.indexOf("move180deg") != -1) {
    if(pos != 180) {
      for(; pos < 180; pos++) {
        myServo.write(pos);
        delay(15);
      }
    }
  }
}

// Fan ---------------------------------------------
void ChangeFanStateWithVoice(String _command) {
  if(_command.indexOf("turnonfan") != -1) {
    digitalWrite(r3, LOW);
  }
  else if(_command.indexOf("turnofffan") != -1) {
    digitalWrite(r3, HIGH);
  }
}

void ChangeFanStateByHandOrFromSensor(String _command) {
  if(_command.indexOf("fanhon") != -1) {
    digitalWrite(r3, LOW);
  }
  else if(_command.indexOf("fanhoff") != -1) {
    digitalWrite(r3, HIGH);
  }
}

// Light ---------------------------------------------
void ChangeLightStateWithVoice(String _command) {
  if(_command.indexOf("turnonlight") != -1) {
    digitalWrite(bLed, HIGH);
  }
  else if(_command.indexOf("turnofflight") != -1) {
    digitalWrite(bLed, LOW);
  }
}

void ChangeLightStateByHandOrFromSensor(String _command) {
  if(_command.indexOf("tonlmp") != -1) {
    digitalWrite(bLed, HIGH);
  }
  else if(_command.indexOf("tofflmp") != -1) {
    digitalWrite(bLed, LOW);
  }
}
