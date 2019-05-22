#include "ev3api.h"
#include "app.h"
#include <stdio.h>
#include <stdbool.h>

#if defined(BUILD_MODULE)
#include "module_cfg.h"
#else
#include "kernel_cfg.h"
#endif

#define DEBUG

#ifdef DEBUG
#define _debug(x) (x)
#else
#define _debug(x)
#endif

///////////////////////////////////////////////////////////////////////

static int      bt_cmd = 0;
static FILE     *bt = NULL;  //ファイルポインタ     

rgb_raw_t rgb_val;
uint8_t color_val;

int selected_port=1;
int sensor[8]={0,0,0,0,0,0,0,0};
int sensor_mode[8]={0,0,0,0,0,0,0,0};
char str[5];

bool end=false;

void main_task(intptr_t unused)
{
    ev3_lcd_set_font(EV3_FONT_MEDIUM);
    ev3_led_set_color(LED_ORANGE);

    int mode=0;
    char write[20];

    ev3_lcd_draw_string("Select Mode",20,0);
    ev3_lcd_draw_string("Left:0-Bluetooth",0,20);
    ev3_lcd_draw_string("Right:1-UART",0,40);

    tslp_tsk(1000);

    while(ev3_button_is_pressed(4)==false){
        ev3_lcd_draw_string("Push Center",30,80);
        
        if(ev3_button_is_pressed(0)==false) {
            mode=1;
            sprintf(write,"%d",mode);
            ev3_lcd_draw_string(write,0,60);
            ev3_lcd_draw_string("                     ",0,80);
        }
        tslp_tsk(500);

        ev3_lcd_draw_string("Push Center",30,80);
        if(ev3_button_is_pressed(1)==false) {
            mode=0;
            sprintf(write,"%d",mode);
            ev3_lcd_draw_string(write,0,60);
            ev3_lcd_draw_string("                     ",0,80);
        }
        tslp_tsk(500);
        
    }

    switch (mode)
    {
        case 0:
            bt = ev3_serial_open_file(EV3_SERIAL_BT);
            ev3_lcd_fill_rect(0,0,EV3_LCD_WIDTH,EV3_LCD_HEIGHT,EV3_LCD_WHITE);
            ev3_lcd_draw_string("Please Start",20,0);
            ev3_lcd_draw_string("BT Mode",20,20);
            break;
        case 1:
            bt = ev3_serial_open_file(EV3_SERIAL_UART);
            ev3_lcd_fill_rect(0,0,EV3_LCD_WIDTH,EV3_LCD_HEIGHT,EV3_LCD_WHITE);
            ev3_lcd_draw_string("Please Start",20,0);
            ev3_lcd_draw_string("UART Mode",20,20);
            break;
        default:
            bt = ev3_serial_open_file(EV3_SERIAL_BT);
            ev3_lcd_fill_rect(0,0,EV3_LCD_WIDTH,EV3_LCD_HEIGHT,EV3_LCD_WHITE);
            ev3_lcd_draw_string("Please Start",20,0);
            ev3_lcd_draw_string("BT Mode",20,20);
            break;
    }

    assert(bt != NULL);
    

    while(1){
        uint8_t c = fgetc(bt);
        if(c=='1'){
            bt_cmd = 1;
        }
        if (bt_cmd == 1){
            break;
        }
    }

    ev3_lcd_fill_rect(0,0,EV3_LCD_WIDTH,EV3_LCD_HEIGHT,EV3_LCD_WHITE);
    LCD_SET();
    ev3_led_set_color(LED_GREEN);
    ev3_sta_cyc(BT_RECIEVE);
    ev3_sta_cyc(BT_SEND);

    /* 以下、main_taskとして任意のプログラムを記述可能(未確認) */

    while(1){}//無限ループ
    
    ext_tsk();
}

void Recieve_value();

void Recieve_value(){
    fgets(str,5,bt);
    ev3_lcd_draw_string(str,30,0);

    if(str[0]=='1'){//Port1
        selected_port=0;
    }
    else if(str[0]=='2'){//Port2
        selected_port=1;
    }
    else if(str[0]=='3'){//Port3
        selected_port=2;
    }
    else if(str[0]=='4'){//Port4
        selected_port=3;
    }
    else if(str[0]=='5'){//PortA
        selected_port=4;
    }
    else if(str[0]=='6'){//PortB
        selected_port=5;
    }
    else if(str[0]=='7'){//PortC
        selected_port=6;
    }
    else if(str[0]=='8'){//PortD
        selected_port=7;
    }
    else if((str[0]=='R')&&(str[2]=='G')){
        switch(str[1]){
            case '1':
                ev3_gyro_sensor_reset(0);
                tslp_tsk(500);
                break;
            case '2':
                ev3_gyro_sensor_reset(1);
                tslp_tsk(500);
                break;
            case '3':
                ev3_gyro_sensor_reset(2);
                tslp_tsk(500);
                break;
            case '4':
                ev3_gyro_sensor_reset(3);
                tslp_tsk(500);
                break;
        }
    }
    else if(((str[0]=='R')&&(str[2]=='L'))||((str[0]=='R')&&(str[2]=='M'))){
        switch(str[1]){
            case 'A':
                ev3_motor_reset_counts(0);
                break;
            case 'B':
                ev3_motor_reset_counts(1);
                break;
            case 'C':
                ev3_motor_reset_counts(2);
                break;
            case 'D':
                ev3_motor_reset_counts(3);
                break;
        }
    }
    else if((str[0]=='9')&&(str[1]=='9')&&(str[2]=='9')&&(str[3]=='9')){
        end=true;
        ev3_stp_cyc(BT_SEND);
    }

    if(str[1]=='0'){//NONE
        sensor[selected_port]=0;
    }
    else if(str[1]=='1'){//ULTRA SONIC
        sensor[selected_port]=1;
    }
    else if(str[1]=='2'){//GYRO
        sensor[selected_port]=2;
    }
    else if(str[1]=='3'){//TOUCH
        sensor[selected_port]=3;
    }
    else if(str[1]=='4'){//COLOR
        sensor[selected_port]=4;
    }
    else if(str[1]=='5'){//HT COLOR
        sensor[selected_port]=5;
    }
    else if(str[1]=='6'){//L motor
        sensor[selected_port]=6;
    }
    else if(str[1]=='7'){//M motor
        sensor[selected_port]=7;
    }

    if(str[2]=='0'){
        sensor_mode[selected_port]=0;
    }
    else if(str[2]=='1'){
        sensor_mode[selected_port]=1;
    }
    else if(str[2]=='2'){
        sensor_mode[selected_port]=2;
    }
    else if(str[2]=='3'){
        sensor_mode[selected_port]=3;
    }
}

void LCD_SET();

void LCD_SET(){
    if(end==true){
        ev3_lcd_fill_rect(0,0,EV3_LCD_WIDTH,EV3_LCD_HEIGHT,EV3_LCD_WHITE);
        ev3_led_set_color(LED_RED);
        ev3_lcd_draw_string("Value Sending",0,20);
        ev3_lcd_draw_string("    was quited",0,40);
        ev3_lcd_draw_string("Please quit",0,60);
        ev3_lcd_draw_string("   EV3 Program",0,80);
        ev3_stp_cyc(BT_RECIEVE);
    }
    else{
        //選択ポート
        if(selected_port==0){
            ev3_lcd_draw_string("   Port 1    ",0,20);
        }
        else if(selected_port==1){
            ev3_lcd_draw_string("   Port 2    ",0,20);
        }
        else if(selected_port==2){
            ev3_lcd_draw_string("   Port 3    ",0,20);
        }
        else if(selected_port==3){
            ev3_lcd_draw_string("   Port 4    ",0,20);
        }
        else if(selected_port==4){
            ev3_lcd_draw_string("   Port A    ",0,20);
        }
        else if(selected_port==5){
            ev3_lcd_draw_string("   Port B    ",0,20);
        }
        else if(selected_port==6){
            ev3_lcd_draw_string("   Port C    ",0,20);
        }
        else if(selected_port==7){
            ev3_lcd_draw_string("   Port D    ",0,20);
        }

        //センサー種類と計測モード
        if(sensor[selected_port]==0){
            ev3_lcd_draw_string("   NONE    ",0,40);
            ev3_sensor_config(selected_port,NONE_SENSOR);
            ev3_motor_config(selected_port-4,0);
            ev3_lcd_draw_string("   none    ",0,60);
        }
        else if(sensor[selected_port]==1){
            ev3_lcd_draw_string("   ULTRA SONIC    ",0,40);
            ev3_sensor_config(selected_port,ULTRASONIC_SENSOR);
            if(sensor_mode[selected_port]==0){
                ev3_lcd_draw_string("   distance    ",0,60);
            }
            else if(sensor_mode[selected_port]==1){
                ev3_lcd_draw_string("   listen    ",0,60);
            }
        }
        else if(sensor[selected_port]==2){
            ev3_lcd_draw_string("   GYRO            ",0,40);
            ev3_sensor_config(selected_port,GYRO_SENSOR);
            if(sensor_mode[selected_port]==0){
                ev3_lcd_draw_string("   angle    ",0,60);
            }
            else if(sensor_mode[selected_port]==1){
                ev3_lcd_draw_string("   rate    ",0,60);
            }
        }
        else if(sensor[selected_port]==3){
            ev3_lcd_draw_string("   TOUCH           ",0,40);
            ev3_sensor_config(selected_port,TOUCH_SENSOR);
            ev3_lcd_draw_string("   state    ",0,60);
        }
        else if(sensor[selected_port]==4){
            ev3_lcd_draw_string("   COLOR           ",0,40);
            ev3_sensor_config(selected_port,COLOR_SENSOR);
            if(sensor_mode[selected_port]==0){
                ev3_lcd_draw_string("   reflect    ",0,60);
            }
            else if(sensor_mode[selected_port]==1){
                ev3_lcd_draw_string("   ambient    ",0,60);
            }
            else if(sensor_mode[selected_port]==2){
                ev3_lcd_draw_string("   color    ",0,60);
            }
            else if(sensor_mode[selected_port]==3){
                ev3_lcd_draw_string("   rgb    ",0,60);
            }
        }
        else if(sensor[selected_port]==5){
            ev3_lcd_draw_string("   HT COLOR        ",0,40);
            ev3_sensor_config(selected_port,HT_NXT_COLOR_SENSOR);
            if(sensor_mode[selected_port]==0){
                ev3_lcd_draw_string("   color    ",0,60);
            }
            else if(sensor_mode[selected_port]==1){
                ev3_lcd_draw_string("   rgb    ",0,60);
            }
        }
        else if(sensor[selected_port]==6){
            ev3_lcd_draw_string("   L MOTOR        ",0,40);
            ev3_motor_config(selected_port-4,LARGE_MOTOR);
            if(sensor_mode[selected_port]==0){
                ev3_lcd_draw_string("   angle    ",0,60);
            }
            else if(sensor_mode[selected_port]==1){
                ev3_lcd_draw_string("   power    ",0,60);
            }
        }
        else if(sensor[selected_port]==7){
            ev3_lcd_draw_string("   M MOTOR        ",0,40);
            ev3_motor_config(selected_port-4,MEDIUM_MOTOR);
            if(sensor_mode[selected_port]==0){
                ev3_lcd_draw_string("   angle    ",0,60);
            }
            else if(sensor_mode[selected_port]==1){
                ev3_lcd_draw_string("   power    ",0,60);
            }
        }
    }
}

void Send_value();

void Send_value(){
    int data[3][8]={{0,0,0},{0,0,0},{0,0,0},{0,0,0},{0,0,0},{0,0,0},{0,0,0},{0,0,0}};
    for(int i=0;i<=7;i++){
        int X=0;
        int Y=0;
        int Z=0;
        //センサー種類と計測モード
        if(sensor[i]==0){
        }
        else if(sensor[i]==1){//ULTRA SONIC
            if(sensor_mode[i]==0){
                data[0][i]=ev3_ultrasonic_sensor_get_distance(i);
            }
            else if(sensor_mode[i]==1){
                data[0][i]=ev3_ultrasonic_sensor_listen(i);
            }
        }
        else if(sensor[i]==2){//GYRO
            if(sensor_mode[i]==0){
                data[0][i]=ev3_gyro_sensor_get_angle(i);
            }
            else if(sensor_mode[i]==1){
                data[0][i]=ev3_gyro_sensor_get_rate(i);
            }
        }
        else if(sensor[i]==3){//TOUCH
            data[0][i]=ev3_touch_sensor_is_pressed(i);
        }
        else if(sensor[i]==4){//COLOR
            if(sensor_mode[i]==0){
                data[0][i]=ev3_color_sensor_get_reflect(i);
            }
            else if(sensor_mode[i]==1){
                data[0][i]=ev3_color_sensor_get_ambient(i);
            }
            else if(sensor_mode[i]==2){
                data[0][i]=ev3_color_sensor_get_color(i);
            }
            else if(sensor_mode[i]==3){
                ev3_color_sensor_get_rgb_raw(i,&rgb_val);
                data[0][i]=rgb_val.r;
                data[1][i]=rgb_val.g;
                data[2][i]=rgb_val.b;
            }
        }
        else if(sensor[i]==5){//HT_COLOR
            if(sensor_mode[i]==0){
                ht_nxt_color_sensor_measure_color(i,&color_val);
                data[0][i]=color_val;
            }
            else if(sensor_mode[i]==1){
                ht_nxt_color_sensor_measure_rgb(i,&rgb_val);
                data[0][i]=rgb_val.r;
                data[1][i]=rgb_val.g;
                data[2][i]=rgb_val.b;
            }
        }
        else if(sensor[i]==6){
            if(sensor_mode[i]==0){
                data[0][i]=ev3_motor_get_counts(i-4);
            }
            else if(sensor_mode[i]==1){
                data[0][i]=ev3_motor_get_power(i-4);
            }
        }
        else if(sensor[i]==7){
            if(sensor_mode[i]==0){
                data[0][i]=ev3_motor_get_counts(i-4);
            }
            else if(sensor_mode[i]==1){
                data[0][i]=ev3_motor_get_power(i-4);
            }
        }

        fprintf(bt,"1%d,%d,%d#2%d,%d,%d#3%d,%d,%d#4%d,%d,%d#5%d#6%d#7%d#8%d#\r\n",
        data[0][0],data[1][0],data[2][0],data[0][1],data[1][1],data[2][1],data[0][2],data[1][2],data[2][2],data[0][3],data[1][3],data[2][3],
        data[0][4],data[0][5],data[0][6],data[0][7]);

        tslp_tsk(10);
    }
    
    
}

void bt_recieve(intptr_t unused)
{
    Recieve_value();

    LCD_SET();
}

void bt_send(intptr_t unused)
{
    Send_value();
}
