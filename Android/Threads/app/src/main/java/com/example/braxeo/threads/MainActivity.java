package com.example.braxeo.threads;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;
import android.os.Handler;
import android.os.Message;

public class MainActivity extends AppCompatActivity {

    Handler hendler = new Handler(){
        @Override
        public void handleMessage(Message msg) {
            TextView brandonsText = (TextView) findViewById(R.id.textView);
            brandonsText.setText("Nice job Hoss");
        }
    };

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    public void clickBrandonsButton(View view){

        Runnable r = new Runnable() {
            @Override
            public void run() {
                long furtureTime = System.currentTimeMillis() + 10000;
                while(System.currentTimeMillis() < furtureTime){
                    synchronized (this) {
                        try{
                            wait(furtureTime - System.currentTimeMillis());
                        }catch(Exception e){}
                    }
                }
                hendler.sendEmptyMessage(0);
            }
        };

        Thread brandonsThread = new Thread(r);
        brandonsThread.start();


    }
}
