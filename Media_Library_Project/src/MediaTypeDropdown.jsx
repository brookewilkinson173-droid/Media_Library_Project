
import { useEffect, useState } from "react";

function MediaTypeDropdown() {
  const [mediaTypes, setMediaTypes] = useState([]);
  const [selectedMedium, setSelectedMedium] = useState("");
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState("");

  useEffect(() => {
    async function fetchMediaTypes() {
      try {
        const response = await fetch(
          "https://localhost:7061/api/media-attributes/media-types" //changed from 7001s
        );

        if (!response.ok) {
          throw new Error(`HTTP error: ${response.status}`);
        }

        const data = await response.json();
        setMediaTypes(data);
      } catch (err) {
        setError(
          "Failed to load media types. Check that the backend is running."
        );
        console.error("Error fetching media types:", err);
      } finally {
        setLoading(false);
      }
    }

    fetchMediaTypes();
  }, []);

  if (loading) {
    return <p>Loading media types...</p>;
  }

  if (error) {
    return <p role="alert">{error}</p>;
  }

  return (
    <div>
      <label htmlFor="mediaType">Select a media type: </label>

      <select
        id="mediaType"
        value={selectedMedium}
        onChange={(event) => setSelectedMedium(event.target.value)}
      >
        <option value="">-- Choose a medium --</option>

        {mediaTypes.map((medium) => (
          <option key={medium} value={medium}>
            {medium}
          </option>
        ))}
      </select>

      {selectedMedium && (
        <p>Selected medium: {selectedMedium}</p>
      )}
    </div>
  );
}

export default MediaTypeDropdown;
