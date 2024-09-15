import { useState } from 'react';

const useAccordion = (initialIndex: number = -1) => {
    const [expanded, setExpanded] = useState(initialIndex);

    const handlePress = (number: number) => {
        if (number != expanded) {
            setExpanded(number);
        }
    };

    return [expanded, handlePress];
};

export default useAccordion;
