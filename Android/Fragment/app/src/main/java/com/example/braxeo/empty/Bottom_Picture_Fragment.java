package com.example.braxeo.empty;

import android.os.Bundle;
import android.support.annotation.Nullable;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;


public class Bottom_Picture_Fragment extends Fragment {

    private static TextView memeTextTop;
    private static TextView memeTextBottom;

    @Nullable
    @Override
    public View onCreateView(LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        View view = inflater.inflate(R.layout.bottom_picture_fragment, container, false);
        memeTextTop = (TextView)view.findViewById(R.id.meme_text_top);
        memeTextBottom = (TextView)view.findViewById(R.id.meme_text_bottom);
        return view;
    }

    public void setMemeText(String top, String bottom){
        memeTextTop.setText(top);
        memeTextBottom.setText(bottom);
    }




}
