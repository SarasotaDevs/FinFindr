def findMinimumShifts(mat):
    rows = len(mat)
    cols = len(mat[0])
    
    # To store the minimum shifts needed to fill each column with `1`s
    min_shifts_needed = [float('inf')] * cols
    
    # Check all possible shifts for each row
    for row in range(rows):
        for shift in range(cols):
            for col in range(cols):
                effective_index = (col - shift + cols) % cols
                if mat[row][effective_index] == 1:
                    # Update the minimum shifts needed to bring a `1` into this column
                    min_shifts_needed[col] = min(min_shifts_needed[col], shift)
    
    # Now calculate the minimum shifts required to make at least one column fully `1`s
    total_min_shifts = float('inf')
    
    for col in range(cols):
        current_shifts = 0
        column_possible = True
        
        for row in range(rows):
            if mat[row][col] == 0 and min_shifts_needed[col] == float('inf'):
                column_possible = False
                break
            if mat[row][col] == 1:
                continue  # No shift needed if there's already a `1` in this column
            current_shifts += min_shifts_needed[col]
        
        if column_possible:
            total_min_shifts = min(total_min_shifts, current_shifts)
    
    # If we found a valid solution, return the minimum shifts required, else return -1
    return total_min_shifts if total_min_shifts != float('inf') else -1

# Example usage:
mat = [
    [0, 1, 0],
    [1, 0, 1],
    [0, 1, 1]
]

result = findMinimumShifts(mat)
print(result)  # Should output 1 if it requires one shift