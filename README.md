# Orchestra-Music-Player
This is a music player created using C#. It wasn't from the scratch, I embed VLC Music Player for this project using axVLCPlugin21. Therefore this project had flaws and these are:
- I used MySQL as a database, although it does not matter to some people, I don't feel like opening XAMPP and starting MySQL. I could have used SQLite if I was aware of such a database when I created this.
- I like anime and I listen to their opening and ending songs. That's why you can observe that there are Japanese characters in the code that will be replaced by a Unicode that is the counterpart of it. I thought of using this kind of solution to solve the problem immediately and started listening to anime music. I should have searched for an API that would replace these characters. Also, this was implemented since MySQL could not read the Japanese characters.
- A user manually adds the music. I should create an algorithm that will automate this process.
- Recently, the new music that I've downloaded in the internet doesn't play and an error dialog appeared, I was busy lately and unable to create a patch for this.
---
Created by John Clifford R. Madriñan (MadrinanComLab)
