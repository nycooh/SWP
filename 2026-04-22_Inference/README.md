## Hausübung vom 15.4.2026: Inference Tests in opencode

# Inference Tests in opencode

Dieses README beschreibt den aktuellen Stand der Tests von Inference-Providern im Free-Tier.

## Teststand

Stand: getestet, Ergebnisse weiter unten aufgeführt.

### Funktioniert gut

- Hugging Face
- OpenRouter
- opencode Zen
- NVIDIA
- GitHub Copilot

### Probleme

1. Google

Fehler:

Your project has been denied access. Please contact support.

Bereits unternommene Schritte:

- Reparatur in Google AI Studio
- 2FA aktiviert
- Neues Projekt angelegt
- Neuen API-Key erstellt

Ergebnis:

Trotz dieser Maßnahmen tritt der Fehler weiterhin auf. Das spricht eher für ein Zugriffs- oder Projektfreigabeproblem bei Google.

2. Groq

Fehler:

Request too large for model qwen/qwen3-32b in organization org_01knrn65yzf2rbjry4npdatpbq service tier on_demand on tokens per minute (TPM): Limit 6000, Requested 32458, please reduce your message size and try again. Need more tokens? Upgrade to Dev Tier today at https://console.groq.com/settings/billing

Beobachtung:

Der Prompt war nur "Good Morning". Im Groq-Dashboard werden trotzdem Tokens verbraucht, obwohl keine Antwort zurückkommt.

## Fazit

Die lokale Konfiguration funktioniert insgesamt gut, weil mehrere Provider stabil laufen. Die offenen Punkte liegen aktuell bei einzelnen Provider-Limits oder Zugriffsrechten, nicht bei opencode selbst.