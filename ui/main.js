const LYRICS = `Neden kaçtın neden?
Mesut olurduk belki
Korkuttum mu seni?
Benden ne zarar gelir ki?

Seni seyretmem, gezmem lazımdı
Bu yolun sonunu bulmam lazımdı
Seni tanımam, bilmem lazımdı
Bu hikâyeye bir son lazımdı

Öyle uzaktan uzaktan hiç konuşmadan nasıl da bağladın beni?
Hani bi' geldin bi' kayboldun, esrarlı mağrurdun, aklıma sardım seni
Öyle uzaktan uzaktan hiç konuşmadan nasıl da bağladın beni?
Hani bi' geldin bi' kayboldun, esrarlı mağrurdun, aklıma sardım seni

Nedir sırrın ne senin?
Çekip bıraktım, sen kimsin?
Toz ol, derdim bitsin
Aklım aşkını yensin

Seni seyretmem, gezmem lazımdı
Bu yolun sonunu bulmam lazımdı
Seni tanımam, bilmem lazımdı
Dudaklarıma bir veda lazımdı

Öyle uzaktan uzaktan hiç konuşmadan nasıl da bağladın beni?
Hani bi' geldin bi' kayboldun, esrarlı mağrurdun, aklıma sardım seni
Öyle uzaktan uzaktan hiç konuşmadan nasıl da bağladın beni?
Hani bi' geldin bi' kayboldun, esrarlı mağrurdun, aklıma sardım seni

Aklıma sardım seni, aklıma sardım seni`

function main() {
  const lyrics = document.getElementById("lyrics")
  let i = -1
  document.addEventListener("keyup", (e) => {
    i++
    const char = LYRICS[i]
    lyrics.innerHTML += char ?? ""
    window.scrollTo(0, document.body.scrollHeight)
  })
}

document.addEventListener("DOMContentLoaded", () => setTimeout(main, 1000))
