package com.example.braxeo.boundservice;

import android.app.Service;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;
import android.os.IBinder;
import android.content.Context;
import android.content.Intent;
import android.content.ComponentName;
import android.content.ServiceConnection;
import com.example.braxeo.boundservice.MyService.MyLocalBinder;

public class MainActivity extends AppCompatActivity {

    MyService brandonsService;
    boolean isBound = false;

    public void showTime(View view) {
        String currentTime = brandonsService.getCurrentTime();
        TextView brandonsText = findViewById(R.id.brandonsText);
        brandonsText.setText(currentTime);

    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        Intent i = new Intent(this, MyService.class);
        bindService(i, sc, Context.BIND_AUTO_CREATE);


    }

    private ServiceConnection sc = new ServiceConnection() {
        @Override
        public void onServiceConnected(ComponentName componentName, IBinder iBinder) {
            MyLocalBinder binder = (MyLocalBinder) iBinder;
            brandonsService = binder.getService();
            isBound = true;
        }

        @Override
        public void onServiceDisconnected(ComponentName componentName) {
                isBound = false;
        }

    };

}
