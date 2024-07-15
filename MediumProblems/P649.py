from collections import deque 
class Solution:
    def predict_party_victory(self, senate: str) -> str:
        # Initialize queues for Radiant and Dire senators' indices
        queue_radiant = deque()
        queue_dire = deque()
      
        # Populate initial queues with the indices of the Radiant and Dire senators
        for index, senator in enumerate(senate):
            if senator == "R":
                queue_radiant.append(index)
            else:
                queue_dire.append(index)
      
        # Calculate the length of the senate for future indexing
        n = len(senate)
      
        # Process the two queues
        while queue_radiant and queue_dire:
            # Take the first senator from each queue and compare their indices
            if queue_radiant[0] < queue_dire[0]:
                # If the Radiant senator comes first, they ban a Dire senator
                # and put themselves at the back of their queue with a new hypothetical index
                queue_radiant.append(queue_radiant[0] + n)
            else:
                # If the Dire senator comes first, they ban a Radiant senator
                # and put themselves at the back of their queue with a new hypothetical index
                queue_dire.append(queue_dire[0] + n)
          
            # Remove the senators who have exercised their powers
            queue_radiant.popleft()
            queue_dire.popleft()
      
        # Return the winning party's name based on which queue still has senators
        return "Radiant" if queue_radiant else "Dire"