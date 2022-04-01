package com.example.cis357_termproject

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import android.widget.TextView

class MainActivity : AppCompatActivity() {
        var numClicks = 0
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        val mainButton = findViewById<Button>(R.id.mainButton)
        val titleLabel = findViewById<TextView>(R.id.totalLabel)

        mainButton.setOnClickListener { v ->
            numClicks += 1
            titleLabel.text = "Clicks: " + numClicks
        }
    }
}