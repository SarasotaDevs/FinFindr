
import { View, StyleSheet, Pressable } from 'react-native';

export const styles = StyleSheet.create({
    viewBackgroundContainer: {
      display: "flex",
      alignItems: 'center',
    },
    cardContainer: {
      display: "flex",
      alignItems: "center",
      width: "90%",
      marginTop: 32,
    },
    line: {
      backgroundColor: "#0A74DA",
      height: 1,
      alignSelf: "center",
      marginTop: 2,
      marginBottom: 8,
      width: "100%"
    },
  });
  
  
export const walletCard = StyleSheet.create({
    walletCard: {
        width: "100%",
        paddingVertical: 24,
        marginTop: 16
    },
    walletCardHeader: { 
        width: "95%",
        alignSelf: "center"
    },
    walletCardHeaderText: {
        fontSize: 30, 
        fontWeight: 'bold',
        textAlign: 'left',
        width: "100%",
        color: "#1877F2",
        fontFamily: 'sans-serif' // Added font family
    },
    walletCardContentText: {
        marginVertical: 8,
        fontSize: 20, 
        fontWeight: 'semibold',
        textAlign: 'left',
        width: "100%",
        color: "#606770",
        fontFamily: 'sans-serif' // Added font family
    },
    walletCardContentTextHeader: {
        marginVertical: 8,
        fontSize: 24, 
        fontWeight: 'semibold',
        textAlign: 'left',
        width: "100%",
        color: "#606770",
        fontFamily: 'sans-serif' // Added font family
    },
    walletCardContentContainer: {
        width: "100%",
        userSelect: 'none',
    },
    addCardButton: {
            backgroundColor: "#0A74DA",
            padding: 32,
            alignSelf: "center",
            color: "white",
            borderRadius: 4,
            fontSize: 20,
            fontFamily: 'sans-serif',
            marginBottom: 16,
            marginTop: 32
    },
    walletCardContentTextHeaderSelected: {
        fontWeight: "bold",
        color: "#1877F2",
        marginVertical: 8,
        fontSize: 24, 
        textAlign: 'left',
        width: "100%",
        fontFamily: 'sans-serif' // Added font family
    }
})


export const sideCards =  StyleSheet.create({
  container: {
      width: "100%",
      display: "flex",
  },
  sideCard: {
    width: "100%",
    paddingVertical: 24,
    marginTop: 16,
  },
  sideCardHeader: { 
    width: "95%",
    alignSelf: "center"

  },
  sideCardHeaderText: {
      fontSize: 24, 
      fontWeight: 'bold',
      textAlign: 'left',
      width: "100%",
      color: "#1877F2",
    },
  sideCardContentText: {
    marginVertical: 8,
    fontSize: 20, 
    fontWeight: 'semibold',
    textAlign: 'left',
    width: "100%",
    color: "#606770"
    
  },
  sideCardContentTextHeader: {
    marginVertical: 8,
    fontSize: 24, 
    fontWeight: 'semibold',
    textAlign: 'center',
    width: "100%",
    color: "#1877F2"
  },
  sideCardContentContainer: {
    width: "100%",
    paddingTop: 24,
    paddingBottom: 8
  },
  loginButton: {
    backgroundColor: "#0A74DA",
    padding: 30,
    alignSelf: "center",
    color: "white",
    borderRadius: 4,
    fontSize: 32,
    fontFamily: 'sans-serif',
    marginBottom: 16,
    marginTop: 32
}
})