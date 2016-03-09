var qSamples: int = 1024;  // array size
var refValue: float = 0.1; // RMS value for 0 dB
var threshold = 0.02;      // minimum amplitude to extract pitch
var rmsValue: float;   // sound level - RMS
var dbValue: float;    // sound level - dB
var pitchValue: float; // sound pitch - Hz
//elli's mouth control points
var movingChin:Transform;
var movingLip1:Transform;
var movingLip2:Transform;
var movingMouthCorner1:Transform;
var movingMouthCorner2:Transform;

var rightEyebrow1:Transform;
var rightEyebrow2:Transform;
var leftEyebrow1:Transform;
var leftEyebrow2:Transform;

//luke's mouth control points
var lukemovingChin:Transform;
var lukemovingLip1:Transform;
var lukemovingLip2:Transform;
var lukemovingMouthCorner1:Transform;
var lukemovingMouthCorner2:Transform;

var lukerightEyebrow1:Transform;
var lukerightEyebrow2:Transform;
var lukeleftEyebrow1:Transform;
var lukeleftEyebrow2:Transform;

var mouthMovement: float;
var maxMove:float = 1;
var currentMove:float;
var mouthCloseSpeed:float = 0.25;

var elliTalking : boolean;
var lukeTalking : boolean;

var eyebrowsUp : boolean;
var eyebrowsDown : boolean;
var eyebrowHeight : float = 0.0008;

var lukeEyebrowsUp : boolean;
var lukeEyebrowsDown : boolean;
var lukeEyebrowHeight : float = 0.0008;

private var samples: float[]; // audio samples
private var spectrum: float[]; // audio spectrum

function Start () {
	samples = new float[qSamples];
	spectrum = new float[qSamples];
}

function AnalyzeSound(){
	//audio.GetOutputData(samples, 0); // fill array with samples
	var i: int;
	var sum: float = 0;
	for (i=0; i < qSamples; i++){
		sum += samples[i]*samples[i]; // sum squared samples
	}	
	
	rmsValue = Mathf.Sqrt(sum/qSamples); // rms = square root of average
	dbValue = 20*Mathf.Log10(rmsValue/refValue); // calculate dB
	if (dbValue < -160) dbValue = -160; // clamp it to -160dB min
	// get sound spectrum
	//audio.GetSpectrumData(spectrum, 0, FFTWindow.BlackmanHarris);
	var maxV: float = 0;
	var maxN: int = 0;
	for (i=0; i < qSamples; i++){ // find max 
		if (spectrum[i] > maxV && spectrum[i] > threshold){
			maxV = spectrum[i];
			maxN = i; // maxN is the index of max
		}
	}
	var freqN: float = maxN; // pass the index to a float variable
	if (maxN > 0 && maxN < qSamples-1){ // interpolate index using neighbours
		var dL = spectrum[maxN-1]/spectrum[maxN];
		var dR = spectrum[maxN+1]/spectrum[maxN];
		freqN += 0.5*(dR*dR - dL*dL);
	}
	pitchValue = freqN*24000/qSamples; // convert index to frequency
}

var display: GUIText; // drag a GUIText here to show results

function Update () {
	if (Input.GetKeyDown("p")){
		GetComponent.<AudioSource>().Play();
	}
	AnalyzeSound();
	if (display){ 
		display.text = "RMS: "+rmsValue.ToString("F2")+
		" ("+dbValue.ToString("F1")+" dB)\n"+
		"Pitch: "+pitchValue.ToString("F0")+" Hz";
	}
	
	if (elliTalking == true) {
		mouthMovement = pitchValue/1000000;
		
		if (mouthMovement < 0){
			mouthMovement -= mouthMovement * 2;
		}
		
		if (mouthMovement == 0 && currentMove > 0){
			movingChin.Translate (0, mouthCloseSpeed*1.5, 0);
			movingLip1.Translate (0, mouthCloseSpeed*1.5, 0);
			movingLip2.Translate (0, mouthCloseSpeed*1.5, 0);
			movingMouthCorner1.Translate (0, mouthCloseSpeed/4, 0);
			movingMouthCorner2.Translate (0, mouthCloseSpeed/4, 0);
			currentMove -= mouthCloseSpeed;	
		}
		else if (currentMove < maxMove/100) {
			movingChin.Translate (0, -mouthMovement*1.5, 0);
			movingLip1.Translate (0, -mouthMovement*1.5, 0);
			movingLip2.Translate (0, -mouthMovement*1.5, 0);
			movingMouthCorner1.Translate (0, -mouthMovement/4, 0);
			movingMouthCorner2.Translate (0, -mouthMovement/4, 0);
			currentMove += mouthMovement;
		}

	}
	
//Elli Eyebrow Control		
	if (eyebrowsUp == true && eyebrowsDown == false) {
		if (eyebrowHeight < 0.0012){
			eyebrowHeight += 0.0001;
			rightEyebrow1.Translate (0, 0.0006*1.5, 0);
			rightEyebrow2.Translate (0, 0.0006, 0);
			leftEyebrow1.Translate (0, 0.0006*1.5, 0);
			leftEyebrow2.Translate (0, 0.0006, 0);
		}
		
	}
	else if (eyebrowsUp == false && eyebrowsDown == false){
		if (eyebrowHeight > 0.0008){
			eyebrowHeight -= 0.0001;
			rightEyebrow1.Translate (0, -0.0006*1.5, 0);
			rightEyebrow2.Translate (0, -0.0006, 0);	
			leftEyebrow1.Translate (0, -0.0006*1.5, 0);
			leftEyebrow2.Translate (0, -0.0006, 0);
		}
					
		else if (eyebrowHeight < 0.0007){
			eyebrowHeight += 0.0001;
			rightEyebrow1.Translate (0.0006, 0.0008*1.5, 0);
			rightEyebrow2.Translate (0, 0.0008, 0);	
			leftEyebrow1.Translate (-0.0006, 0.0008*1.5, 0);
			leftEyebrow2.Translate (0, 0.0008, 0);
		}				
		
	}
	else if (eyebrowsUp == false && eyebrowsDown == true) {
		
		if (eyebrowHeight > 0.0002){
			eyebrowHeight -= 0.0001;
			rightEyebrow1.Translate (-0.0006, -0.0008*1.5, 0);
			rightEyebrow2.Translate (0, -0.0008, 0);
			leftEyebrow1.Translate (0.0006, -0.0008*1.5, 0);
			leftEyebrow2.Translate (0, -0.0008, 0);
		}
		
	}
	
	if (lukeTalking == true) {
		mouthMovement = pitchValue/1000000;
		
		if (mouthMovement < 0){
			mouthMovement -= mouthMovement * 2;
		}
		
		if (mouthMovement == 0 && currentMove > 0){
			lukemovingChin.Translate (0, mouthCloseSpeed*2, 0);
			lukemovingLip1.Translate (0, mouthCloseSpeed*2, 0);
			lukemovingMouthCorner1.Translate (0, (mouthCloseSpeed/4)*2, 0);
			lukemovingMouthCorner2.Translate (0, (mouthCloseSpeed/4)*2, 0);
			currentMove -= mouthCloseSpeed;	
		}
		else if (currentMove < maxMove/100) {
			lukemovingChin.Translate (0, -mouthMovement*2, 0);
			lukemovingLip1.Translate (0, -mouthMovement*2, 0);
			lukemovingMouthCorner1.Translate (0, (-mouthMovement/4)*2, 0);
			lukemovingMouthCorner2.Translate (0, (-mouthMovement/4)*2, 0);
			currentMove += mouthMovement;
		}
	}
	
//Luke Eyebrow Control		
	if (lukeEyebrowsUp == true && lukeEyebrowsDown == false) {
		if (lukeEyebrowHeight < 0.0012){
			lukeEyebrowHeight += 0.0001;
			rightEyebrow1.Translate (0, 0.0006*1.5, 0);
			rightEyebrow2.Translate (0, 0.0006, 0);
			leftEyebrow1.Translate (0, 0.0006*1.5, 0);
			leftEyebrow2.Translate (0, 0.0006, 0);
		}
		
	}
	else if (lukeEyebrowsUp == false && lukeEyebrowsDown == false){
		if (lukeEyebrowHeight > 0.0008){
			lukeEyebrowHeight -= 0.0001;
			lukerightEyebrow1.Translate (0, -0.0006*1.5, 0);
			lukerightEyebrow2.Translate (0, -0.0006, 0);	
			lukeleftEyebrow1.Translate (0, -0.0006*1.5, 0);
			lukeleftEyebrow2.Translate (0, -0.0006, 0);
		}
					
		else if (lukeEyebrowHeight < 0.0007){
			lukeEyebrowHeight += 0.0001;
			lukerightEyebrow1.Translate (0.0006, 0.0008*1.5, 0);
			lukerightEyebrow2.Translate (0, 0.0008, 0);	
			lukeleftEyebrow1.Translate (-0.0006, 0.0008*1.5, 0);
			lukeleftEyebrow2.Translate (0, 0.0008, 0);
		}				
		
	}
	else if (lukeEyebrowsUp == false && lukeEyebrowsDown == true) {
		
		if (lukeEyebrowHeight > 0.0002){
			lukeEyebrowHeight -= 0.0001;
			lukerightEyebrow1.Translate (-0.0006, -0.0008*1.5, 0);
			lukerightEyebrow2.Translate (0, -0.0008, 0);
			lukeleftEyebrow1.Translate (0.0006, -0.0008*1.5, 0);
			lukeleftEyebrow2.Translate (0, -0.0008, 0);
		}
		
	}
	
	
	 
}
