async function start(sleep) {
	while(true) {	
		await new Promise(resolve => setTimeout(resolve, sleep))
		const simulate = new MouseEvent('click', {
		view: window,
		bubbles: true,
		cancelable: true,
		clientX: 100,
	});

	document.body.dispatchEvent(simulate);
	}
}