export let userExists = (username : string) => {
    if (username.length > 0) {
        return true
    } else {
        return false
    }
}