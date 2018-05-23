package com.example.braxeo.imageeffects;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;

import android.content.Context;
import android.content.ContextWrapper;
import android.graphics.Bitmap;
import android.graphics.Color;
import android.graphics.drawable.BitmapDrawable;
import android.graphics.drawable.Drawable;
import android.graphics.drawable.LayerDrawable;
import android.os.Environment;
import android.provider.MediaStore;
import android.widget.ImageView;

public class MainActivity extends AppCompatActivity {

    ImageView brandonsImageView;
    Drawable brandonsFace;
    Bitmap bitmapImage;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        brandonsImageView = (ImageView) findViewById(R.id.brandonsImageView);



        brandonsFace = getResources().getDrawable(R.drawable.face);
        bitmapImage = ((BitmapDrawable) brandonsFace).getBitmap();
        Bitmap newPhoto = invertImage(bitmapImage);
        brandonsImageView.setImageBitmap(newPhoto);



        /*
        Drawable[] layers = new Drawable[2];
         layers[0] = getResources().getDrawable(R.drawable.face);
         layers[1] = getResources().getDrawable(R.drawable.abs);

        LayerDrawable layderDrawable = new LayerDrawable(layers);
        brandonsImageView.setImageDrawable(layderDrawable);

        */

        MediaStore.Images.Media.insertImage(getContentResolver(), newPhoto, "title", "description");
    }

    private static Bitmap invertImage(Bitmap image){
        Bitmap finalImage = Bitmap.createBitmap(image.getWidth(), image.getHeight(), image.getConfig());

        int A, R, G, B;
        int pixelColor;
        int height = image.getHeight();
        int width = image.getWidth();

        for(int y = 0; y < height; y++){
            for (int x = 0; x < width; x++){
                pixelColor = image.getPixel(x, y);
                A = Color.alpha(pixelColor);
                R = 255 - Color.red(pixelColor);
                G = 255 - Color.green(pixelColor);
                B = 255 - Color.blue(pixelColor);

                finalImage.setPixel(x, y, Color.argb(A, R, G, B));
            }
        }
        return finalImage;

    }
}
