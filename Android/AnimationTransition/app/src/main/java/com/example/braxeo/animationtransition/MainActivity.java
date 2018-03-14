package com.example.braxeo.animationtransition;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.MotionEvent;
import android.view.View;
import android.view.ViewGroup;
import android.widget.RelativeLayout;
import android.transition.TransitionManager;

public class MainActivity extends AppCompatActivity {

    ViewGroup brandonsLayout;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        brandonsLayout = (ViewGroup)findViewById(R.id.main_view);
        brandonsLayout.setOnTouchListener(
                new RelativeLayout.OnTouchListener(){
                    @Override
                    public boolean onTouch(View view, MotionEvent motionEvent) {
                        moveButton();
                        return true;
                    }
                }
        );


    }


    public void moveButton(){
        View brandonsButton = findViewById(R.id.button);

        TransitionManager.beginDelayedTransition(brandonsLayout);

        // Change the poistion of the button
        RelativeLayout.LayoutParams positionRules = new RelativeLayout.LayoutParams(
                RelativeLayout.LayoutParams.WRAP_CONTENT,
                RelativeLayout.LayoutParams.WRAP_CONTENT);
        positionRules.addRule(RelativeLayout.ALIGN_PARENT_BOTTOM, RelativeLayout.TRUE);
        positionRules.addRule(RelativeLayout.ALIGN_PARENT_RIGHT, RelativeLayout.TRUE);
        brandonsButton.setLayoutParams(positionRules);

        // Change the size of the button
        ViewGroup.LayoutParams sizeRules = brandonsButton.getLayoutParams();
        sizeRules.width = 450;
        sizeRules.height = 300;
        brandonsButton.setLayoutParams(sizeRules);



    }
}
