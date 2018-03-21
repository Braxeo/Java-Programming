package com.example.braxeo.intents;

import android.app.IntentService;
import android.content.Intent;
import android.support.annotation.Nullable;
import android.util.Log;

public class brandonsIntentService extends IntentService {

    private static final String TAG = "com.example.braxeo";

    public brandonsIntentService() {
        super("brandonsIntentService");
    }

    @Override
    protected void onHandleIntent(@Nullable Intent intent) {
        // This iss what the service does
        Log.i(TAG, "The Service has now started");

    }
}
