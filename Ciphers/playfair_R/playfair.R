m <- matrix(c('E', 'S', 'M', 'P', 'I',
              'O', 'L', 'A', 'Y', 'F',
              'R', 'B', 'C', 'D', 'G',
              'H', 'K', 'N', 'Q', 'T',
              'U', 'V', 'W', 'X', 'Z'),
            nrow = 5, ncol = 5, byrow = TRUE)


get_digrams <- function(word){
  #remove all spaces
  word <- gsub(" ", "", word)
  word <- toupper(word)
  
  #check if the word has an odd length: if so, add an 'X' to the end of the string
  # if(length(word) %% 2 != 0){
  #   word <- paste(word, 'X', sep = '')
  # }
  
  #digrams list
  digrams <- c()
  i <- 1
  
  while(i <= nchar(word)){
    if(i + 1 <= nchar(word)){
      sub_string <- substr(word, i, i+1)
      first_letter <- substr(sub_string, 1, 1)
      second_letter <- substr(sub_string, 2, 2)
      
      #check if letters are the same, add 'X' after the first and go on
      if(first_letter == second_letter){
        sub_string <- paste(first_letter, 'X', sep = '')
        word <- paste(substr(word, 1, i), sub_string, substr(word, i+2, nchar(word)), sep = '')
      }
      
    }
    #if the number of letters is odd, add an 'X' to the word
    else{
      word <- paste(word, 'X', sep = '')
      sub_string <- paste(substr(word, i, i), 'X', sep = '')
    }
    digrams <- c(digrams, sub_string)
    i = i + 2
  }
  return(digrams)
}

encrypt <- function(word){
  
  #get digrams
  digrams <- get_digrams(word)
  
  result <- ''
  
  for(i in 1:length(digrams)){
    s <- digrams[i]
    first <- substr(s, 1, 1)
    second <- substr(s, 2, 2)
    first_indexes <- which(m == first, arr.ind = T)
    second_indexes <- which(m == second, arr.ind = T)
    
    #if letters are in the same row, take the letter to the right
    if(first_indexes[1] == second_indexes[1]){
      if(first_indexes[2] + 1 > nrow(m)){
        first_letter_result <- m[first_indexes[1], 1]
      }
      else{
        first_letter_result <- m[first_indexes[1], first_indexes[2] + 1]
      }
      if(second_indexes[2] + 1 > nrow(m)){
        second_letter_result <- m[second_indexes[1], 1]
      }
      else{
        second_letter_result <- m[second_indexes[1], second_indexes[2] + 1]
      }
    }
    
    #if letters are in the same column, take the letter below
    if(first_indexes[2] == second_indexes[2]){
      if(first_indexes[1] + 1 > nrow(m)){
        first_letter_result <- m[1, first_indexes[2]]
      }
      else{
        first_letter_result <- m[first_indexes[1] + 1, first_indexes[2]]
      }
      if(second_indexes[1] + 1 > nrow(m)){
        second_letter_result <- m[1, second_indexes[2]]
      }
      else{
        second_letter_result <- m[second_indexes[1] + 1, second_indexes[2]]
      }
    }
    
    #if letters are not in the same row or column, take the ones that form a rectangle
    else{
      first_letter_result <- m[first_indexes[1], second_indexes[2]]
      second_letter_result <- m[second_indexes[1], first_indexes[2]]
    }
    
    result <- paste(result, first_letter_result, second_letter_result, sep = '')
  }
  
  return(result)
}




############ INPUT #####################
word <- "Nel mezzo del cammin di nostra vita mi ritrovai in una selva oscura"
########################################

result <- encrypt(word)
print(result)
