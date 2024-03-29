class vowels:
    ALL_VOWELS = "AEIUYOeaiuyo"

    def __init__(self, text):
        self.text = text
        self.vowels_in_text = [el for el in self.text if el in vowels.ALL_VOWELS]

    def __iter__(self):
        return self

    def __next__(self):
        if not self.vowels_in_text:
            raise StopIteration

        return self.vowels_in_text.pop(0)
