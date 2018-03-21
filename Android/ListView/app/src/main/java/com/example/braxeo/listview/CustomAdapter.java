package com.example.braxeo.listview;

import android.content.Context;
import android.support.annotation.NonNull;
import android.support.annotation.Nullable;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.ImageView;
import android.widget.TextView;


class CustomAdapter extends ArrayAdapter<String> {
    public CustomAdapter(@NonNull Context context, String[] foods) {
        super(context, R.layout.custom_row, foods);
    }

    @NonNull
    @Override
    public View getView(int position, @Nullable View convertView, @NonNull ViewGroup parent) {
        LayoutInflater brandonsInflater = LayoutInflater.from(getContext());
        View customView = brandonsInflater.inflate(R.layout.custom_row, parent, false);

        String singleFoodItem = getItem(position);
        TextView brandonsText = customView.findViewById(R.id.brandonsTextView);
        ImageView brandonsImage = customView.findViewById(R.id.brandonsImage);

        brandonsText.setText(singleFoodItem);
        brandonsImage.setImageResource(R.mipmap.tomcat);
        return customView;

    }
}
