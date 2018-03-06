package com.example.braxeo.allison;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.RelativeLayout;
import android.widget.Button;
import android.graphics.Color;
import android.widget.EditText;
import android.content.res.Resources;
import android.util.TypedValue;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        // RelativeLayout
        RelativeLayout buckysLayout = new RelativeLayout(this);
        buckysLayout.setBackgroundColor(Color.GREEN);

        // Creating widget for layout
        Button redButton = new Button(this);
        redButton.setText("Login");
        redButton.setBackgroundColor(Color.RED);

        // username input
        EditText username = new EditText(this);

        // widget IDS

        redButton.setId(1);
        username.setId(2);

        // Setting Layout parameters
        RelativeLayout.LayoutParams buttonDetails = new RelativeLayout.LayoutParams(
          RelativeLayout.LayoutParams.WRAP_CONTENT,
          RelativeLayout.LayoutParams.WRAP_CONTENT
        );

        // Setting Layout parameters
        RelativeLayout.LayoutParams usernameDetails = new RelativeLayout.LayoutParams(
                RelativeLayout.LayoutParams.WRAP_CONTENT,
                RelativeLayout.LayoutParams.WRAP_CONTENT
        );

        // give rules to position widgets
        usernameDetails.addRule(RelativeLayout.ABOVE, redButton.getId());
        usernameDetails.addRule(RelativeLayout.CENTER_HORIZONTAL);
        usernameDetails.setMargins(0, 0,0,50);

        Resources r = getResources();
        int px = (int) TypedValue.applyDimension(
                TypedValue.COMPLEX_UNIT_DIP, 200, r.getDisplayMetrics());

        username.setWidth(px);

        // Setting Layout Rules
        buttonDetails.addRule(RelativeLayout.CENTER_HORIZONTAL);
        buttonDetails.addRule(RelativeLayout.CENTER_VERTICAL);

        // Adding widget to layout with details
        buckysLayout.addView(redButton, buttonDetails);
        buckysLayout.addView(username, usernameDetails);

        // Setting Layout as content view
        setContentView(buckysLayout);

    }
}
