import android.view.View
import androidx.databinding.ObservableField
import androidx.lifecycle.ViewModel

class MyNotesViewModel : ViewModel() {

    val isSaveButtonEnabled = ObservableField<Boolean>(false)
    val isShowNoteButtonEnabled = ObservableField<Boolean>(false)
    val showNoteButtonVisibility = ObservableField<Int>(View.INVISIBLE)

    fun onTextChanged(text: CharSequence?) {
        isSaveButtonEnabled.set(!text.isNullOrBlank())
    }

    fun onNoteLoaded(savedNote: String) {
        isShowNoteButtonEnabled.set(savedNote.isNotEmpty())
        showNoteButtonVisibility.set(if (savedNote.isNotEmpty()) View.VISIBLE else View.INVISIBLE)
    }
}
