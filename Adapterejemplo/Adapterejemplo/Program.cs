using Adapterejemplo;


CommunicationSystem communicationSystem = new CommunicationSystem();
EnglishSpeaker englishSpeaker = new EnglishSpeaker();

communicationSystem.StartConversation(englishSpeaker, "How are you", "Im fine");

SpanishSpeaker spanishSpeaker = new SpanishSpeaker();
Translator translator = new Translator(spanishSpeaker);

communicationSystem.StartConversation(translator, "Como estas", "Bien gracias");



