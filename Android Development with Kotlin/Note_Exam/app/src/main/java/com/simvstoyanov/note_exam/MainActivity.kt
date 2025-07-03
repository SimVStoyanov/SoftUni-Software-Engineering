import android.content.Context
import android.content.SharedPreferences
import android.hardware.Sensor
import android.hardware.SensorEvent
import android.hardware.SensorEventListener
import android.hardware.SensorManager
import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.widget.Button
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.isVisible
import com.simvstoyanov.note_exam.databinding.ActivityMainBinding


class MainActivity : AppCompatActivity(), SensorEventListener {

    private lateinit var binding: ActivityMainBinding
    private lateinit var sharedPreferences: SharedPreferences

    private lateinit var sensorManager: SensorManager
    private var accelerometer: Sensor? = null

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityMainBinding.inflate(layoutInflater)
        setContentView(binding.root)

        sharedPreferences = getPreferences(Context.MODE_PRIVATE)
        sensorManager = getSystemService(Context.SENSOR_SERVICE) as SensorManager
        accelerometer = sensorManager.getDefaultSensor(Sensor.TYPE_ACCELEROMETER)

        binding.saveButton.setOnClickListener {
            saveNote()
        }

        binding.showNoteButton.setOnClickListener {
            showNote()
        }

        checkSavedNote()
    }

    private fun saveNote() {
        val note = binding.noteEditText.text.toString()
        if (note.isNotEmpty()) {
            with(sharedPreferences.edit()) {
                putString(KEY_NOTE, note)
                apply()
            }
            binding.noteEditText.text.clear()
        }
    }

    private fun showNote() {
        val savedNote = sharedPreferences.getString(KEY_NOTE, "")
        if (savedNote != null) {
            if (savedNote.isNotEmpty()) {
                binding.noteEditText.setText(savedNote)
            }
        }
    }

    private fun checkSavedNote() {
        val savedNote = sharedPreferences.getString(KEY_NOTE, "")
        if (savedNote != null) {
            binding.showNoteButton.isEnabled = savedNote.isNotEmpty() && savedNote != binding.noteEditText.text.toString()
        }
        binding.saveButton.isEnabled = binding.noteEditText.text.isNotEmpty() && savedNote != binding.noteEditText.text.toString()
    }

    override fun onResume() {
        super.onResume()
        accelerometer?.let { sensorManager.registerListener(this, it, SensorManager.SENSOR_DELAY_NORMAL) }
    }

    override fun onPause() {
        super.onPause()
        sensorManager.unregisterListener(this)
    }

    override fun onAccuracyChanged(sensor: Sensor?, accuracy: Int) {
        // Not used in this example
    }

    override fun onSensorChanged(event: SensorEvent?) {
        event?.let {
            val zValue = it.values[2]
            if (zValue < -8.5) {
                binding.noteEditText.text.clear()
            }
        }
    }

    companion object {
        const val KEY_NOTE = "key_note"
    }
}
