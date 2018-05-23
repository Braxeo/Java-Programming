package com.example.braxeo.videoplayer;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.VideoView;
import android.widget.MediaController;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        final VideoView brandonsVideoView = (VideoView)findViewById(R.id.brandonsVideoView);
        brandonsVideoView.setVideoPath("https://www.thenewboston.com/forum/project_files/006_testVideo.mp4");

        // player controls (play, poause, stop, etc...)
        MediaController mediaController = new MediaController(this);
        mediaController.setAnchorView(brandonsVideoView);

        brandonsVideoView.setMediaController(mediaController);
        brandonsVideoView.start();


    }
}
